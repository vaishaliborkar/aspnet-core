using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Timing;
using AppliedTech.TaskApp.Reminders.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedTech.TaskApp.Reminders
{
    public class ReminderAppService : TaskAppAppServiceBase, IReminderAppService
    {
        private readonly IRepository<Reminder, long> _reminderRepository;
        private readonly IRepository<Seen, long> _seenRepository;

        public ReminderAppService(IRepository<Reminder, long> reminderRepository, IRepository<Seen, long> seenRepository)
        {
            _reminderRepository = reminderRepository;
            _seenRepository = seenRepository;
        }


        public async Task<ListResultDto<ReminderListDto>> GetById(long input)
        {
            var seen = await _seenRepository
                   .GetAll()
                   .Where(s => s.CreatorUserId == input)
                   .OrderByDescending(t => t.CreationTime)
                   .ToListAsync();


            var reminders = await _reminderRepository
                   .GetAll()
                   .Where(r => r.ReminderDateTime <= Clock.Now)
                   .OrderByDescending(t => t.CreationTime)
                   .ToListAsync();

            var filteredReminders =
                reminders
                .Where(a => !seen.Select(b => b.ReminderId).Contains(a.Id)).ToList();

            return new ListResultDto<ReminderListDto>(
                ObjectMapper.Map<List<ReminderListDto>>(filteredReminders)
            );
        }

        public async Task Create(CreateReminderInput input)
        {
            var reminder = ObjectMapper.Map<Reminder>(input);
            await _reminderRepository.InsertAsync(reminder);
        }

        public async Task Update(UpdateReminderInput input)
        {
            var reminder = ObjectMapper.Map<Reminder>(input);
            await _reminderRepository.UpdateAsync(reminder);
        }

        public async Task Delete(long Id)
        {
            var reminder = _reminderRepository.Get(Id);
            await _reminderRepository.DeleteAsync(reminder);
        }

        public async Task CreateSeen(CreateSeenInput input)
        {
            var seen = ObjectMapper.Map<Seen>(input);
            await _seenRepository.InsertAsync(seen);
        }
    }
}
