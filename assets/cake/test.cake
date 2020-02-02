Task("Test")
.Does(() => {
  DotNetCoreTest("**/*.sln");
});