using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace InpText
{
    internal class AddPeson
    {
        public bool Info(string name, string lastName, string national_Code, string gender)
        {
            if (!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(national_Code) || string.IsNullOrEmpty(gender)))
            {
                bool nationalCode = ExtensionMethod.NationalCode(national_Code);
                if (nationalCode)
                {
                    var person = new Person();
                    person.Name = name;
                    person.lastname = lastName;
                    person.National_code = national_Code;
                    person.Gender = gender;
                    var frm = Application.OpenForms[nameof(FrmPerson)] as FrmPerson;
                    frm.Persson.Add(person);
                    return true;
                }
            }
            return false;
        }
    }
}
