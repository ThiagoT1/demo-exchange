﻿namespace Demo.Exchange.Application.Queries.ObterTaxaCobrancaPorSegmento
{
    using MediatR;

    public class ObterTaxaCobrancaPorSegmentoQuery : Request, IRequest<ObterTaxaCobrancaPorSegmentoResponse>
    {
        public ObterTaxaCobrancaPorSegmentoQuery(string tipoSegmento)
        {
            TipoSegmento = tipoSegmento;
        }

        public string TipoSegmento { get; }

        public override Response Response => new ObterTaxaCobrancaPorSegmentoResponse(RequestId);
    }
}