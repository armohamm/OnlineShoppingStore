using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "lightman.miao@gmail.com";
        public string MailFromAddress = "lightman.miao@gmail.com";
        public bool UseSsl = true;
        public string Username = "lightman.miao@gmail.com";
        public string Password = "Your password";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
