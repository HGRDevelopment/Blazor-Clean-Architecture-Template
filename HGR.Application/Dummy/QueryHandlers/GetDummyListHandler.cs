using HGR.Application.Abstractions;
using HGR.Application.Dummy.Queries;
using HGR.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Application.Dummy.QueryHandlers
{
    public class GetDummyListHandler : IRequestHandler<GetDummyListQuery, List<Dummyentitiy>>
    {
        private readonly IDummyRepository _dummyRepository;

        public GetDummyListHandler(IDummyRepository dummyRepository)
        {
            _dummyRepository = dummyRepository;
        }
        public async Task<List<Dummyentitiy>> Handle(GetDummyListQuery request, CancellationToken cancellationToken)
        {
            return await _dummyRepository.GetAll();
        }
    }
}
