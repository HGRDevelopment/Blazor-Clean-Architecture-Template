﻿using HGR.Application.Abstractions;
using HGR.Application.Dummy.Commands;
using HGR.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application.Dummy.CommandHandlers
{
    public class DeleteDummyHandler(IDummyRepository dummyRepository) : IRequestHandler<DeleteDummyCommand>
    {
        public async Task Handle(DeleteDummyCommand request, CancellationToken cancellationToken)
        {
            await dummyRepository.DeleteDummy(request.Id);
        }
    }
}
