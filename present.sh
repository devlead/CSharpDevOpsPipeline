open "http://localhost:9000"
docker run --rm -it -v $(PWD):/repo -p 9000:9000 gitpitch/desktop:pro