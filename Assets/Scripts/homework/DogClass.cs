

public class DogClass

{
        //Variables
        public int Age;
        public float Height;
        public float Weight;
        public bool Generder;
        public string Name;
        public bool Hungry;
        public float Energy;
        public string Breeds;
        public bool Happy;
        public string Color;
        public int Speed;

        //Constructor
        public DogClass(int _age, float _height, float _weight, bool _generder, string _name, string _breeds,string _color)
        {
            Age = _age;
            Height = _height;
            Weight = _weight;
            Generder = _generder;
            Name = _name;
            Hungry = true;
            Energy = 100;
            Breeds = _breeds;
            Happy = true;
            Color = _color;
            Speed = 100;
        }
        //Functions

        public string Getdogbreeds()
        {
            return Breeds;

        }

        public string GetdogName()
        {
            return Name;
        }

        public string GetdogColor()
        {
            return Color;
        }

        public int GetdogAge()
        {
            return Age;
        }

        public float GetdogHeight()
        {
            return Height;
        }

        public float GetdogWeight()
        {
            return Weight;
        }


        public void Living()
        {
            Aging();
            Eating();
            Sleeping();
            Walking();
        }

        public void Aging()
        {
            Age = Age + 1;
            Energy = Energy - 1;
        }
        public void Walking()
        {
            Happy = true;
            Hungry = true;
            Energy = Energy - 1;

        }

        public void Eating()
        {
            Hungry = false;
            Happy = true;
            Energy = Energy + 1;
        }

        public void Sleeping()
        {
            Energy = Energy + 1;
            Happy = false;
            Hungry = true;

        }


    }

