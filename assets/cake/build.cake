Task("Build")
.Does(() => {
  DotNetCoreBuild("src");
});