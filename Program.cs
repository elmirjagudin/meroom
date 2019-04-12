using System;


class Program
{

    static void SplitProgress(float done)
    {
Console.WriteLine($"split {done}");
    }

    static void MeshroomProgress(string chunkName, float done)
    {
Console.WriteLine($"chunk {chunkName} {done}");
    }

    static void Main(string[] args)
    {
        var timeBase = new TimeBase { Numerator = 1001, Denominator = 30000 };
        var ffmpegBin = "/usr/bin/ffmpeg";
        //var videoFile = "/home/boris/droneMov/falafel_low.mov";
        var videoFile = "/home/boris/droneMov/valkarra_sunny.mov";

Console.WriteLine("video {0}", videoFile);

         uint NumFrames;
         string ImagesDir;
         PrepVideo.SplitFrames(ffmpegBin, videoFile, SplitProgress, out NumFrames, out ImagesDir);
Console.WriteLine("done spliting hairs, {0} NumFrames", NumFrames);
        PrepVideo.ExtractSubtitles(ffmpegBin, videoFile);

//        NumFrames = 1499u;
//        ImagesDir = "/home/boris/droneMov/panopt/valkarra_sunny";
        MeshroomCompute.PhotogrammImages(
            "/home/boris/Meshroom-2019.1.0/meshroom_compute",
            "/home/boris/Meshroom-2019.1.0/aliceVision/share/aliceVision/cameraSensors.db",
            "/home/boris/Meshroom-2019.1.0/aliceVision/share/aliceVision/vlfeat_K80L3.SIFT.tree",
            ImagesDir, timeBase, NumFrames, MeshroomProgress);
    }
}

