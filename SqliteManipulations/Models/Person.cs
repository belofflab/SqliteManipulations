using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteManipulations.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Sex { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }
        public string Class { get; set; }
        public string UGroup { get; set; }
        public string Hobby { get; set; }
        public string EyeColor { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, LastName: {LastName}, FirstName: {FirstName}, " +
                   $"DateOfBirth: {DateOfBirth}, Sex: {Sex}, Street: {Street}, " +
                   $"House: {House}, Flat: {Flat}, Class: {Class}, UGroup: {UGroup}, " +
                   $"Hobby: {Hobby}, EyeColor: {EyeColor}";
        }

    }
}
