using VideoConvertor;

namespace MediaProcessorTests
{
    public class MediaProcessorTests
    {
        [Fact]
        public void GetVideoMetadata_ShouldReturnMetadata()
        {
            // Arrange
            var mediaProcessor = new MediaProcessor();
            var inputFilePath = "Videos\\Police.mp4";

            // Act
            var metadata = mediaProcessor.GetVideoMetadata(inputFilePath);

            // Assert
            Assert.NotNull(metadata);
            //Assert.Contains("Duration", metadata); // فرض می‌کنیم "Duration" در خروجی وجود دارد
        }

        [Fact]
        public void TakeScreenshot_ShouldCreateImage()
        {
            // Arrange
            var mediaProcessor = new MediaProcessor();
            var inputFilePath = "Videos\\Police.mp4";
            var timestamp = TimeSpan.FromSeconds(10); // 10 ثانیه
            var outputImagePath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\screenshot.png";

            // Act
            mediaProcessor.TakeScreenshot(inputFilePath, timestamp, outputImagePath);

            // Assert
            Assert.True(File.Exists(outputImagePath));
        }

        [Fact]
        public void TrimVideo_ShouldCreateTrimmedVideo()
        {
            // Arrange
            var mediaProcessor = new MediaProcessor();
            var inputFilePath = "Videos\\Police.mp4";
            var startTime = TimeSpan.FromSeconds(10); // 10 ثانیه
            var endTime = TimeSpan.FromSeconds(30);   // 20 ثانیه 
            var outputFilePath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\trimmed.mp4";
            var resolution = "1280x720";

            // Act
            mediaProcessor.TrimVideo(inputFilePath, startTime, endTime, outputFilePath);

            // Assert
            Assert.True(File.Exists(outputFilePath));
        }

        [Fact]
        public void ExtractAudio_ShouldCreateAudioFile()
        {
            // Arrange
            var mediaProcessor = new MediaProcessor();
            var inputFilePath = "Videos\\Police.mp4"; 
            var outputAudioPath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\extracted_audio.mp3";

            // Act
            mediaProcessor.ExtractAudio(inputFilePath , outputAudioPath);

            // Assert
            Assert.True(File.Exists(outputAudioPath));
        }

        [Fact]
        public void GenerateAudioFromText_ShouldThrowNotImplementedException()
        {
            // Arrange
            var mediaProcessor = new MediaProcessor();
            var text = "Hello, World!";
            var outputAudioPath = "E:\\MtaliProject\\Seied\\VideoCompressor\\MediaProcessorTests\\Export\\output_audio.mp3";

            // Act & Assert
            Assert.Throws<NotImplementedException>(() => mediaProcessor.GenerateAudioFromText(text, outputAudioPath));
        }
    }
}