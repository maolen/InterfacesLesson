using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLesson
{
    public class EmployeeSalaryService
    {
        public void SendMoneyToEmployee(string employeeAddress)
        {
            // сложная логика для отправки денег Skrill
            ISender sender = CreatorService.MessageSender;
            sender.To = employeeAddress;
            sender.From = "bill@gmail.com";
            sender.SendMessage("Вам начислили зарплату.");
        }
    }
}
