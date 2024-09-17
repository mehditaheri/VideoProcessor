using VideoConvertor;

namespace MediaProcessorTests_MS
{
    [TestClass]
    public class MediaProcessorTests
    {
        [TestMethod]
        public async Task GetVideoMetadata_ShouldReturnMetadata()
        {
            // Arrange
            var mediaProcessor = new MediaProcessor();
            var inputFilePath = "Videos\\Police.mp4";

            // Act
            var metadata = await mediaProcessor.GetVideoMetadata(inputFilePath);

            // Assert
            Assert.IsNotNull(metadata); 
        }

        [TestMethod]
        public async Task TakeScreenshot_ShouldCreateImage()
        {
            // Arrange
            var mediaProcessor = new MediaProcessor();
            var inputFilePath = "Videos\\Police.mp4";
            var timestamp = TimeSpan.FromSeconds(0); // 0 ثانیه
            var outputImagePath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\screenshot.png";

            if (File.Exists(outputImagePath))
                File.Delete(outputImagePath);

            // Act
            await mediaProcessor.TakeScreenshot(inputFilePath, timestamp, outputImagePath);

            // Assert
            Assert.IsTrue(File.Exists(outputImagePath));
        }

        //[TestMethod]
        //public void TrimVideo_ShouldCreateTrimmedVideo()
        //{
        //    // Arrange
        //    var mediaProcessor = new MediaProcessor();
        //    var inputFilePath = "Videos\\Police.mp4";
        //    var startTime = TimeSpan.FromSeconds(10); // 10 ثانیه
        //    var endTime = TimeSpan.FromSeconds(30);   // 20 ثانیه 
        //    var outputFilePath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\trimmed.mp4";
        //    var resolution = "1280x720";

        //    // Act
        //    mediaProcessor.TrimVideo(inputFilePath, startTime, endTime, outputFilePath);

        //    // Assert
        //    Assert.IsTrue(File.Exists(outputFilePath));
        //}

        //[TestMethod]
        //public void ExtractAudio_ShouldCreateAudioFile()
        //{
        //    // Arrange
        //    var mediaProcessor = new MediaProcessor();
        //    var inputFilePath = "Videos\\Police.mp4";
        //    var outputAudioPath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\extracted_audio.mp3";

        //    // Act
        //    mediaProcessor.ExtractAudio(inputFilePath, outputAudioPath);

        //    // Assert
        //    Assert.IsTrue(File.Exists(outputAudioPath));
        //}

        //[TestMethod]
        //public void GenerateAudioFromText_ShouldThrowNotImplementedException()
        //{
        //    // Arrange
        //    var mediaProcessor = new MediaProcessor();
        //    var text = "Hello, World!";
        //    var outputAudioPath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\output_audio.mp3";

        //    // Act & Assert
        //    Assert.ThrowsException<NotImplementedException>(() => mediaProcessor.GenerateAudioFromText(text, outputAudioPath));
        //}
    }
}