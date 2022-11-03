using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.IO;


namespace BlazorApp3.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(IBrowserFile file)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("File");
            var gridFS = new GridFSBucket(database);
            Stream stream = file.OpenReadStream();
            gridFS.UploadFromStreamAsync(file.Name, stream);

         
        }

      

        public void DownloadToLocal()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}DeserializedBall.jpg", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName("sss.jpg", fs);
            }
        }
    }
}
