using System;
using System.IO;

class Program
{
    static string[] GetImgs()
    {
        return new string[]
        {
            "/home/boris/droneMov/falafel_low/chunk1_tst/0466.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0481.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0496.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0510.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0525.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0540.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0555.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0570.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0585.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0600.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0615.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0630.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0645.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0660.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0675.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0690.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0705.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0720.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0735.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0750.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0765.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0780.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0795.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0810.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0825.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0840.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0855.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0870.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0885.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0900.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0915.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0930.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0945.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0960.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0975.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0990.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1005.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1020.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1035.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1050.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1065.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1080.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1095.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1110.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1125.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1140.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1155.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1170.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1185.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/1200.jpg",
        };
    }

    static void MakeMeshroomJson()
    {
        string[] imgs = new string[]
        {
            "/home/boris/droneMov/falafel_low/chunk1_tst/0466.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0481.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0496.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0510.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0525.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0540.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0555.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0570.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0585.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0600.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0615.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0630.jpg",
            "/home/boris/droneMov/falafel_low/chunk1_tst/0645.jpg",
        };

        var graph = new PipelineJson(2720.44015, 3840, 2160, imgs,//GetImgs(),
            "/home/boris/Meshroom-2019.1.0/aliceVision/share/aliceVision/cameraSensors.db",
            "/home/boris/Meshroom-2019.1.0/aliceVision/share/aliceVision/vlfeat_K80L3.SIFT.tree",
            true
            );

        Console.WriteLine("{0}", graph.Dumps());
        graph.WriteToFile("/home/boris/droneMov/falafel_low/chunk1_tst/auto.mg");
    }

    static void SplitProgress(float done)
    {
Console.WriteLine("split done {0}", done);
    }

    static void Main(string[] args)
    {
        //MakeMeshroomJson();
        var frames = PrepVideo.SplitFrames(
            "/usr/bin/ffmpeg",
            //"/home/boris/droneMov/valkarra_sunny.mov",
            "/home/boris/droneMov/falafel_low.mov",
            SplitProgress);

Console.WriteLine("done spliting hairs, {0} frmes", frames);
    }
}

