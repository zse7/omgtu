using System;
using System.Runtime.InteropServices;

class C
{
    static void Main()
    {
        string sortname="Ryu", sortporoda = "Pug", sortokras = "white", sortdr = "2018";
        Dog [] dogs = new Dog[10];
        dogs[0] = new Dog("Lucky", "Beagle", "black", "2010");
        dogs[1] = new Dog("Ryu", "Pug", "brown", "2018");
        dogs[2] = new Dog("Chester", "Chihuahua", "black", "2011");
        dogs[3] = new Dog("Lucky", "Beagle", "white", "2010");
        dogs[4] = new Dog("Chip", "Chihuahua", "white", "2015");
        dogs[5] = new Dog("Chester", "Pug", "brown", "2015");
        dogs[5] = new Dog("Chip", "Pug", "brown", "2015");
        dogs[6] = new Dog("Ryu", "Beagle", "white", "2013");
        dogs[7] = new Dog("Spike", "Chihuahua", "gray", "2011");
        dogs[8] = new Dog("Pete", "Pug", "brown", "2018");
        dogs[9] = new Dog("Spike", "Beagle", "black", "2013");
        Console.WriteLine("Сортировка по кличке: " + sortname);
        for (int i = 0; i < dogs.Length; i++)
        {
            Dog dog = dogs[i];
            if (dog.sortByname(dog, sortname) != null)
            {
                Console.WriteLine(dog.getInfo(dog.sortByname(dog,sortname)));
            }
        }
        Console.WriteLine("Сортировка по породе: " + sortporoda);
        for (int i = 0; i < dogs.Length; i++)
        {
            Dog dog = dogs[i];
            if (dog.sortByporoda(dog, sortporoda) != null)
            {
                Console.WriteLine(dog.getInfo(dog.sortByporoda(dog, sortporoda)));   
            }      
        }
        Console.WriteLine("Сортировка по окраске: " + sortokras);
        for (int i = 0;i < dogs.Length;i++)
        {
            Dog dog = dogs[i];
            if (dog.sortByokras(dog, sortokras) != null)
            {
                Console.WriteLine(dog.getInfo(dog.sortByokras(dog, sortokras)));
            }
        }
        Console.WriteLine("Сортировка по году рождения: " + sortdr);
        for (int i = 0; i < dogs.Length; i++)
        {
            Dog dog= dogs[i];
            if (dog.sortBydr(dog, sortdr) != null)
            {
                Console.WriteLine(dog.getInfo(dog.sortBydr(dog, sortdr)));
            }
        }

    }
}
class Dog
{
    private string name; 
    private string poroda;
    private string okras;
    private string dr;
    public Dog(string name,string poroda, string okras, string dr)
    {
        this.name = name;
        this.poroda = poroda;
        this.okras = okras;
        this.dr = dr;
    }
    public Dog sortByname(Dog dog, string name)
    {
        if (dog.name.Equals(name)) return dog;
        else return null;
    }
    public Dog sortByporoda(Dog dog, string poroda)
    {
        if (dog.poroda.Equals(poroda)) return dog;
        else return null;
    }
    public Dog sortByokras(Dog dog, string okras)
    {
        if (dog.okras.Equals(okras)) return dog;
        else return null;
    }
    public Dog sortBydr(Dog dog, string dr)
    {
        if (dog.dr.Equals(dr)) return dog;
        else return null;
    }
    public string getname(Dog dog)
    {
        return dog.name;
    }
    public string getporoda(Dog dog)
    {
        return dog.poroda;
    }
    public string getokras(Dog dog)
    {
        return dog.okras;
    }
    public string getdr(Dog dog)
    {
        return dog.dr;
    }
    public String getInfo(Dog dog)
    {
        if (dog != null)
        {
            return "Кличка: " + dog.name + "; Порода: " + dog.poroda + "; Окрас: " + dog.okras + "; ДР: " + dog.dr;
        }
        else return null;
    }
    public void setname(string name)
    {
        this.name = name;
    }
    public void setporoda(string poroda)
    {
        this.poroda = poroda;
    }
    public void setokras(string okras)
    {
        this.okras = okras;
    }
    public void setdr(string dr)
    {
        this.dr = dr;
    }
}