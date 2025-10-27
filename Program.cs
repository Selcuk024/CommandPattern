using System;
using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomFan = new CeilingFan("Living Room");

            Light garageLight = new Light("Garage Light");
            GarageDoor garageDoor = new GarageDoor(garageLight);

            Stereo stereo = new Stereo();

            LightOnCommand lightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand lightOff = new LightOffCommand(livingRoomLight);

            CeilingFanMediumCommand fanMedium = new CeilingFanMediumCommand(livingRoomFan);
            CeilingFanHighCommand fanHigh = new CeilingFanHighCommand(livingRoomFan);
            CeilingFanOffCommand fanOff = new CeilingFanOffCommand(livingRoomFan);

            GarageDoorUpCommand garageUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOnCd = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, lightOn, lightOff);
            remoteControl.SetCommand(1, fanMedium, fanOff);
            remoteControl.SetCommand(2, fanHigh, fanOff);
            remoteControl.SetCommand(3, garageUp, garageDown);
            remoteControl.SetCommand(4, stereoOnCd, stereoOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);

            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();

            MacroCommand partyOn = new MacroCommand(new Command[]
            {
                lightOn, fanMedium, stereoOnCd
            });

            MacroCommand partyOff = new MacroCommand(new Command[]
            {
                lightOff, fanOff, stereoOff
            });

            remoteControl.SetCommand(5, partyOn, partyOff);

            Console.WriteLine("Party ON (macro)");
            remoteControl.OnButtonWasPushed(5);

            Console.WriteLine("Party OFF (macro)");
            remoteControl.OffButtonWasPushed(5);

            Console.WriteLine("Undo party (macro)");
            remoteControl.UndoButtonWasPushed();
        }
    }
}
