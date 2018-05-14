using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Repositories;
using AppliedTech.TaskApp.People;
using System.Linq;

namespace AppliedTech.TaskApp.Common
{
    public class LookupAppService : TaskAppAppServiceBase, ILookupAppService
    {
        private readonly IRepository<Person, Guid> _personRepository;

        public LookupAppService(IRepository<Person, Guid> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetPeopleComboboxItems()
        {
            var people = await _personRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                people.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
            );
        }
    }
}
