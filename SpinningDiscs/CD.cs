using System;
namespace SpinningDiscs
{
    public class CD : SpinningMediaDisc, IBurnable
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public  CD(string discData, bool discIsBlank, int date) : base(discData, discIsBlank, date) { }


        public void BurnDevice(string newMedia)
        {
            Data = newMedia;
        }

        public override string Play()
        {
            return Data;
        }
    }
}
