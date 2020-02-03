Task("Publish")
.Does(() => {
  TFBuild.Commands.UploadArtifactDirectory(
      "./artifacts",
      "NuGet");
});