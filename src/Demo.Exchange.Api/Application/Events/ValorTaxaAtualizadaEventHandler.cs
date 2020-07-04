﻿namespace Demo.Exchange.Application.Events
{
    using Demo.Exchange.Application.Commands.RegistrarTaxaInCache;
    using Demo.Exchange.Domain.AggregateModel.TaxaModel;
    using MediatR;
    using Microsoft.Extensions.Logging;
    using System.Threading;
    using System.Threading.Tasks;

    public class ValorTaxaAtualizadaEventHandler : Handler, INotificationHandler<ValorTaxaAtualizadaEvent>
    {
        public ValorTaxaAtualizadaEventHandler(IMediator mediator, ILoggerFactory logger)
            : base(mediator, logger.CreateLogger<ValorTaxaAtualizadaEventHandler>())
        {
        }

        public async Task Handle(ValorTaxaAtualizadaEvent notification, CancellationToken cancellationToken)
        {
            var response = await Mediator.Send(new RegistrarTaxaInCacheCommand(notification.Id));
            if (response.IsFailure)
                Logger.LogWarning("");
        }
    }
}