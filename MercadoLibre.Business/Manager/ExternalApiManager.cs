// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.DataAccess;
using MercadoLibre.Domain.Dto;
using MercadoLibre.Domain.Dto.Response;
using System.Collections.Generic;

namespace MercadoLibre.Business.Manager
{
    public class ExternalApiManager
    {
        internal ExternalApiManager()
        { }

        public ItemResponseDto GetItem(string id, string url)
        {
            ItemResponseDto itemResponse = null;

            ItemDto item = DataAccessFacade.ExternalApiClient.GetItem(id, url);
            if (item != null)
            {
                DomainDto domain = DataAccessFacade.ExternalApiClient.GetDomain(item.DomainId, url);
                if (domain != null)
                {
                    itemResponse = MergeAttributes(item, domain);
                }
            }

            return itemResponse;
        }

        private object CalculateAdditionalInfo(string component, string value)
        {
        }

        private bool IsComponentIncluded(string component)
        {
            return new List<string> { "NUMBER_OUTPUT", "BOOLEAN_OUTPUT", "TEXT_OUTPUT", "NUMBER_UNIT_OUTPUT" }.Contains(component);
        }

        private ItemResponseDto MergeAttributes(ItemDto item, DomainDto domain)
        {
            ItemResponseDto itemResponse = new ItemResponseDto { Id = item.Id, Title = item.Title, Groups = new List<GroupResponseDto>() };

            domain.Groups.ForEach(g =>
            {
                GroupResponseDto groupResponseDto = new GroupResponseDto { Id = g.Id, Components = new List<ComponentResponseDto>() };
                g.Components.ForEach(c =>
                {
                    if (IsComponentIncluded(c.Component))
                    {
                        ComponentResponseDto componentResponseDto = new ComponentResponseDto { Component = c.Component, Label = c.Label };

                        c.Attributes.ForEach(a =>
                        {
                            AttributeResponseDto attributeResponseDto = new AttributeResponseDto { Id = a.Id, ValueType = a.ValueType };

                            //Merge here
                            AttributeDto attributeDto = SearchAttribute(item, a.Id);
                            if (attributeDto != null)
                            {
                                attributeResponseDto.AttributeMatched = true;
                                attributeResponseDto.ValueType = a.ValueType;
                                attributeResponseDto.AdditionalInfo = CalculateAdditionalInfo(c.Component, attributeDto.ValueName);
                                attributeResponseDto.Value = attributeDto;
                            }
                            else
                            {
                                attributeResponseDto.AttributeMatched = false;
                            }

                            componentResponseDto.Attributes.Add(attributeResponseDto);
                        });

                        groupResponseDto.Components.Add(componentResponseDto);
                    }
                });

                itemResponse.Groups.Add(groupResponseDto);
            });

            return itemResponse;
        }

        private AttributeDto SearchAttribute(ItemDto item, string attributeId)
        {
            foreach (AttributeDto attribute in item.Attributes)
            {
                if (attributeId == attribute.Id)
                {
                    return attribute;
                }
            }

            return null;
        }
    }
}