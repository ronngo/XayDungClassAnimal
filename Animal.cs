namespace XayDungClassAnimal
{
    public abstract class Animal
    {
       

        public string Weight { get; set; }
        public string Height { get; set; }

        public Animal(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }
        public abstract void PrintInfo();
    }
}