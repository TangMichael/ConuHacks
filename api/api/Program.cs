﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
//using CommandLine;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Speech.V1;
using Grpc.Auth;
using NAudio;

namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseUrls("http://localhost:5000", "http://odin:5000")
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build();
            host.Run();

        }


        //public static async Task<object> StreamingMicRecognizeAsync(int seconds)
        //{
        //    if (NAudio.Wave.WaveIn.DeviceCount < 1)
        //    {
        //        Console.WriteLine("No microphone!");
        //        return -1;
        //    }
        //    var speech = SpeechClient.Create();
        //    var streamingCall = speech.StreamingRecognize();
        //    // Write the initial request with the config.
        //    await streamingCall.WriteAsync(
        //        new StreamingRecognizeRequest()
        //        {
        //            StreamingConfig = new StreamingRecognitionConfig()
        //            {
        //                Config = new RecognitionConfig()
        //                {
        //                    Encoding =
        //                    RecognitionConfig.Types.AudioEncoding.Linear16,
        //                    SampleRateHertz = 16000,
        //                    LanguageCode = "en",
        //                },
        //                InterimResults = true,
        //            }
        //        });
        //    // Print responses as they arrive.
        //    Task printResponses = Task.Run(async () =>
        //    {
        //        while (await streamingCall.ResponseStream.MoveNext(
        //            default(CancellationToken)))
        //        {
        //            foreach (var result in streamingCall.ResponseStream
        //                .Current.Results)
        //            {
        //                foreach (var alternative in result.Alternatives)
        //                {
        //                    Console.WriteLine(alternative.Transcript);
        //                }
        //            }
        //        }
        //    });
        //    // Read from the microphone and stream to API.
        //    object writeLock = new object();
        //    bool writeMore = true;
        //    var waveIn = new NAudio.Wave.WaveInEvent();
        //    waveIn.DeviceNumber = 0;
        //    waveIn.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);
        //    waveIn.DataAvailable +=
        //        (object sender, NAudio.Wave.WaveInEventArgs args) =>
        //        {
        //            lock (writeLock)
        //            {
        //                if (!writeMore) return;
        //                streamingCall.WriteAsync(
        //                    new StreamingRecognizeRequest()
        //                    {
        //                        AudioContent = Google.Protobuf.ByteString
        //                            .CopyFrom(args.Buffer, 0, args.BytesRecorded)
        //                    }).Wait();
        //            }
        //        };
        //    waveIn.StartRecording();
        //    Console.WriteLine("Speak now.");
        //    await Task.Delay(TimeSpan.FromSeconds(seconds));
        //    // Stop recording and shut down.
        //    waveIn.StopRecording();
        //    lock (writeLock) writeMore = false;
        //    await streamingCall.WriteCompleteAsync();
        //    await printResponses;
        //    return 0;
        //}
    }
}
