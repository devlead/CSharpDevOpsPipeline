Task("Build")
.Does(() => {
  DotNetCoreBuild("**/*.sln");
});