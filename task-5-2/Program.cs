// Создать программу для имитации работы клиники.  
// Пусть в клинике будет три врача: хирург, терапевт и дантист.  
// Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.  
// Так же предусмотреть класс «Пациент» и класс «План лечения».
// Создать объект класса «Пациент» и добавить пациенту план лечения.
// Так же создать метод, который будет назначать врача пациенту согласно  плану лечения.  
// Если план лечения имеет код 1 – назначить хирурга и выполнить метод  лечить.  
// Если план лечения имеет код 2 – назначить дантиста и выполнить метод  лечить.  
// Если план лечения имеет любой другой код – назначить терапевта и  выполнить метод лечить. 

enum DoctorType
{
    Surgeon = 1,
    Dentist = 2,
    Internist = 3 
}
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

class TreatmentPlan
{
    public DoctorType DoctorType { get; set; }

    public TreatmentPlan(DoctorType doctorType)
    {
        DoctorType = doctorType;
    }
}

class Patient
{
    public TreatmentPlan Plan { get; set; }

    public Patient(TreatmentPlan plan)
    {
        Plan = plan;
    }
}

class Program 
{
    static void Main()
    {
        TreatmentPlan plan = new TreatmentPlan(DoctorType.Surgeon);
        Patient patient = new Patient(plan);
        AssignDoctor(patient.Plan);
    }

    static void AssignDoctor(TreatmentPlan plan)
    {
        Doctors doctor;
        switch (plan.DoctorType)
        {
            case DoctorType.Surgeon:
                doctor = new Surgeon();
                break;
            case DoctorType.Dentist:
                doctor = new Dentist();
                break;
            case DoctorType.Internist:
                doctor = new Internist();
                break;
            default:
                doctor = new Internist();
                break;
        }
        doctor.Treat();
    }
}



