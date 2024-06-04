// Создать программу для имитации работы клиники.  
// Пусть в клинике будет три врача: хирург, терапевт и дантист.  
// Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.  
// Так же предусмотреть класс «Пациент» и класс «План лечения».
// Создать объект класса «Пациент» и добавить пациенту план лечения.
// Так же создать метод, который будет назначать врача пациенту согласно  плану лечения.  
// Если план лечения имеет код 1 – назначить хирурга и выполнить метод  лечить.  
// Если план лечения имеет код 2 – назначить дантиста и выполнить метод  лечить.  
// Если план лечения имеет любой другой код – назначить терапевта и  выполнить метод лечить. 

abstract class Doctors
{
    public abstract void Treat();
}

class Surgeon : Doctors 
{
    public override void Treat()
    {
        Console.WriteLine("Make a surgery");
    }
}

class Internist : Doctors 
{
    public override void Treat()
    {
        Console.WriteLine("Write prescription");
    }
}

class Dentist : Doctors 
{
    public override void Treat()
    {
        Console.WriteLine("Clean teeth");
    }
}

class Patient
{
    public TreatmentPlan treatmentPlan = new TreatmentPlan();
    public Doctors doctor;
    
    public void AssignDoctor()
    {
        if (int.TryParse(treatmentPlan.code, out int number))
        {
            if (number == 1)
            {
                doctor = new Surgeon();
                doctor.Treat();
            }
            else if (number == 2)
            {
                doctor = new Dentist();
                doctor.Treat();
            }
            else
            {
                doctor = new Internist();
                doctor.Treat();
            }
        }
        else
        {
            Console.WriteLine("This is not a number");
        }
    }
}

class TreatmentPlan
{
    public string code = Console.ReadLine();
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to select service");
        Patient patient = new Patient();
        patient.AssignDoctor();
    }
}
