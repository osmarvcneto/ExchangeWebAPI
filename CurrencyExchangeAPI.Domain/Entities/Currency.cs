using CurrencyExchangeAPI.Domain.Interfaces.Entities;
using System;

namespace CurrencyExchangeAPI.Domain.Entities
{
    /// <summary>
    /// Classe Representado a Moeda
    /// </summary>
    public class Currency : IEntityBase
    {
        /// <summary>
        /// Código da Moeda
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nome da Moeda
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valor Máximo
        /// </summary>
        public decimal High { get; set; }

        /// <summary>
        /// Valor Mínimo
        /// </summary>
        public decimal Low { get; set; }

        /// <summary>
        /// Valor de Compra
        /// </summary>
        public decimal Bid { get; set; }

        /// <summary>
        /// Valor de Venda
        /// </summary>
        public decimal Ask { get; set; }

        /// <summary>
        /// Variação cambial
        /// </summary>
        public decimal VariationBid { get; set; }

        /// <summary>
        /// Porcentagem de Variação
        /// </summary>
        public decimal PercentChange { get; set; }

        /// <summary>
        /// Data e Hora de criação
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
