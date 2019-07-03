using System;

namespace Character
{
    /// <summary>
    /// types of cars
    /// </summary>
    public enum Types
    {
        Volvo,
        Mers,
        BMV,
        Ford,
        CrashCar
    }


    public interface IDrive
    {
        void Drive();
    }
    /// <summary>
    /// strategy implementations
    /// </summary>
    public class DriveVolvo : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Volvo drive");
        }
    }

    public class DriveBMV : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("BMV drive");
        }
    }

    public class DriveMers : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Mers drive");
        }
    }
    public class DriveCrashCar : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Car is broken doesn't go");
        }
    }
    /// <summary>
    /// strategy context
    /// </summary>
    public class DriveCar
    {
        IDrive DriveMethod;

        public DriveCar(IDrive drivemethod)
        {
            SetDriveMethod(drivemethod);
        }

        public void SetDriveMethod(IDrive driveMethod)
        {
            DriveMethod = driveMethod;
        }

        public void Drive()
        {
            DriveMethod.Drive();
        }
    }

    /// <summary>
    /// client of contex
    /// </summary>
    public class GameLogic
    {
        DriveCar first;
        void Init()
        {
            first = new DriveCar(new DriveVolvo());
        }
        void OnCarCrash()
        {
            first.SetDriveMethod(new DriveCrashCar());
        }
        void NeedToDriveCar()
        {
            first.Drive();
        }
    }
}