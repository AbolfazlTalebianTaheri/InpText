using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
namespace InpText
{
    public class EditPerson
    {
        static int house_number;

        public bool Info(string name, string lastName, string national_code, string gender)
        {
            if (!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(national_code) || string.IsNullOrEmpty(gender)))
            {
                int index = EditPerson.Index;
                var person = new Person();
                person.Name = name;
                person.lastname = lastName;
                person.National_code = national_code;
                person.Gender = gender;
                successful = true;
                var frm = Application.OpenForms[nameof(FrmPerson)] as FrmPerson;
                frm.Persson.RemoveAt(index);
                frm.Persson.Insert(index, person);
                //frm.Persson[index] = person;
                return true;
            }
            return false;
        }
        public static bool successful = false;
        public static bool Successful_Operation
        {
            get
            {
                return successful;
            }
        }
        public static int Index
        {
            get
            {
                return house_number;
            }
            set
            {
                house_number = value;
            }
        }
    }
}
