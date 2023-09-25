# GitHub.Demo

This is a .NET solution with a console application and a unit test project. The console application is located in the `src/GitHub.Demo.App` directory and the unit test project is located in the `tests/GitHub.Demo.App.Tests` directory.

It's used for GitHub Copilot demo purposes. Just for MS Build Spotlight events in The Netherlands and BeLux. 2023.

## Requirements

To build and run this project, you need to have the following installed:

- .NET Core SDK 3.1 or later
- Docker (optional)

## Building the Application

To build the console application, navigate to the `src/GitHub.Demo.App` directory and run the following command:

```
dotnet build
```

This will compile the application and create a binary in the `bin` directory.

## Running the Application

To run the console application, navigate to the `src/GitHub.Demo.App` directory and run the following command:

```
dotnet run
```

This will start the application and display the output in the console.

## Building the Docker Image

To build a Docker image for the console application, navigate to the `src/GitHub.Demo.App` directory and run the following command:

```
docker build -t github-demo-app .
```

This will build a Docker image with the tag `github-demo-app`.

## Running the Docker Container

To run the Docker container for the console application, run the following command:

```
docker run github-demo-app
```

This will start the container and display the output in the console.

## Running the Unit Tests

To run the unit tests, navigate to the `tests/GitHub.Demo.App.Tests` directory and run the following command:

```
dotnet test
```

This will run all the unit tests and display the results in the console.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- [xUnit](https://xunit.net/) - Unit testing framework for .NET
- [Docker](https://www.docker.com/) - Containerization platform