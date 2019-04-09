using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static IEnumerable<string> Images(string ImgsDir, IEnumerable<uint> frameNums)
    {
        foreach (var frame in frameNums)
        {
            var fname = string.Format("{0:D4}.jpg", frame);
            yield return Path.Combine(ImgsDir, fname);
        }
    }

    static void MakeMeshroomGraphs(string ImagesDir, IEnumerable<IEnumerable<uint>> Chunks)
    {
        uint chunkNum = 0;
        foreach (var chunk in Chunks)
        {
            var graphFile = Path.Combine(ImagesDir, string.Format("chunk{0}.mg", chunkNum));
            var graph = new PipelineJson(2720.44015, 3840, 2160, Images(ImagesDir, chunk),
                        "/home/boris/Meshroom-2019.1.0/aliceVision/share/aliceVision/cameraSensors.db",
                        "/home/boris/Meshroom-2019.1.0/aliceVision/share/aliceVision/vlfeat_K80L3.SIFT.tree"
            );
            graph.WriteToFile(graphFile);

            chunkNum += 1;
        }
    }

    static void SplitProgress(float done)
    {
Console.WriteLine("split done {0}", done);
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
//  Console.WriteLine("done spliting hairs, {0} NumFrames", NumFrames);
//         PrepVideo.ExtractSubtitles(ffmpegBin, videoFile);

//        NumFrames = 2157u;
//        ImagesDir = "/home/boris/droneMov/panopt/falafel_low";
        MakeMeshroomGraphs(ImagesDir, Chunks.GetChunks(timeBase, NumFrames));
    }
}

