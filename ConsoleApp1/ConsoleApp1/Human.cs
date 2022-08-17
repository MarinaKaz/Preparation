using System;
using System.Collections.Generic;
using System.Text;

/*3.Создать свой класс Human с полями
uint Height - рост,
string EyesColor - цвет глаз,
string Sex - пол,
List<string> PetNames - список имён питомцев человека, может быть пустым, или заполненным любым числом имён
и написать метод, который принимает объект этого класса и возвращает полную его копию.
*/

namespace ConsoleApp1
{
    class Human : ICloneable
    {
        public uint Height;
        public string EyesColor;
        public string Sex;
        public List<string> PetNames;

        public Human(uint height, string eyesColor, string sex, List<string> petName)
        {
            Height = height;
            EyesColor = eyesColor;
            Sex = sex;
            PetNames = petName;
        }

        public Human(uint height, string eyesColor, string sex)
        {
            Height = height;
            EyesColor = eyesColor;
            Sex = sex;
        }

        public object Clone()
        {
            //return (Human)this.MemberwiseClone();
            return new Human(Height, EyesColor, Sex, PetNames);
        }
    }
}
