// This file was auto-generated by ML.NET Model Builder. 

using System;
using Multiplant_Disease_vs_Healthy_ML_ModelML.Model;

namespace Multiplant_Disease_vs_Healthy_ML_ModelML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                ImageSource = @"C:\Users\miste\OneDrive - Arizona State University\Desktop\School\Capstone\MultiPlant Disease vs Healthy Dataset\tf_plant_disease_classification-master\data\diseased_data\Basil wilted 1.jpg",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
            Console.WriteLine($"ImageSource: {sampleData.ImageSource}");
            Console.WriteLine($"\n\nPredicted Label value {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
