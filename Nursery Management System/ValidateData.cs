using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class ValidateData
    {
        public bool checkMails(string mail)
        {
            int posOFdind = -1;
            for(int i=0; i<mail.Length; i++)
            {
                if(mail[i]=='@')
                {
                    posOFdind = i + 1;
                    break;
                }
            }
            int size = mail.Length;
            if (mail[size - 1] == 'm' && mail[size - 2] == 'o' && mail[size - 3] == 'c' && mail[size - 3] == '.' && size - 5 > posOFdind && posOFdind != -1 && posOFdind > 0)
                return true;
            return false;
        }
        public bool checkPhoneNum(string phoneNum)
        {

            if(phoneNum.Length!=11 || phoneNum[0]!='0' || phoneNum[1]!='1' || !(phoneNum[2]=='0' || phoneNum[2] == '1' || phoneNum[2] == '2' || phoneNum[2] == '5'))
            return false;
            for(int i=0; i< phoneNum.Length; i++)
            {
                if (!(phoneNum[i] >= '0' && phoneNum[i] <= '9'))
                    return false;
            
            }
            return true;
        }
        public bool checkNationalID(string ID)
        {
            for (int i = 0; i < ID.Length; i++)
            {
                if (!(ID[i] >= '0' && ID[i] <= '9'))
                    return false;

            }
            if (ID.Length != 11     || !(ID[0] == '2' || ID[0] == '3'))
                return false;
            return true;

        }
        public bool checkCreditCardt(string ID)
        {
            for (int i = 0; i < ID.Length; i++)
            {
                if (!(ID[i] >= '0' && ID[i] <= '9'))
                    return false;

            }
            if (ID.Length != 16)
                return false;
            return true;

        }

    }
}
