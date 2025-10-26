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
            GarageDoor garageDoor = new GarageDoor("Main House");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand lightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand lightOff = new LightOffCommand(livingRoomLight);
            CeilingFanMediumCommand fanMedium = new CeilingFanMediumCommand(livingRoomFan);
            CeilingFanHighCommand fanHigh = new CeilingFanHighCommand(livingRoomFan);
            CeilingFanOffCommand fanOff = new CeilingFanOffCommand(livingRoomFan);
            GarageDoorUpCommand garageUp = new GarageDoorUpCommand(garageDoor);
            StereoOnWithCdCommand stereoOnCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, lightOn, lightOff);
            remoteControl.SetCommand(1, fanHigh, fanOff);
            remoteControl.SetCommand(2, garageUp, garageUp);
            remoteControl.SetCommand(3, stereoOnCd, stereoOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            fanMedium.Execute();
            fanHigh.Execute();
            fanOff.Execute();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();

            MacroCommand partyOn = new MacroCommand(new Command[]
            {
                lightOn, fanMedium, stereoOnCd
            });

            MacroCommand partyOff = new MacroCommand(new Command[]
            {
                lightOff, fanOff, stereoOff
            });

            remoteControl.SetCommand(4, partyOn, partyOff);

            Console.WriteLine("Party ON (macro)");
            remoteControl.OnButtonWasPushed(4);

            Console.WriteLine("Party OFF (macro)");
            remoteControl.OffButtonWasPushed(4);

            Console.WriteLine("Undo party (macro)");
            remoteControl.UndoButtonWasPushed();

        }
    }
}
