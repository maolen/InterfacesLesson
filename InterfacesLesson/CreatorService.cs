using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLesson
{
    public static class CreatorService
    {
        public static ISender MessageSender
        {
            get
            {
                return new TelegramSender();
            }
        }
    }
}
