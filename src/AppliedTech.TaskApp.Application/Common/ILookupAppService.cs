using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedTech.TaskApp.Common
{
    public interface ILookupAppService : IApplicationService
    {
        Task<ListResultDto<ComboboxItemDto>> GetPeopleComboboxItems();
    }
}
