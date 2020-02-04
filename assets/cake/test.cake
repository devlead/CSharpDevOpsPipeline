Task("Test")
.Does(() => {
  DotNetCoreTest("src");
});