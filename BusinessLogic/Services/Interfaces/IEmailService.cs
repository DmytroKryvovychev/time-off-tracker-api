﻿using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string body);
    }
}
