# LimeFlightTakeHomeChallenge
This is the Take Home challenge for LimeFlight Backend engineer position. You have one week time to complete it. You need to create a PR to this repository.
## Prerequisites

You need to have Docker Desktop installed in order to run Docker. 

## Setup

In the root directory of the project you need to run 
`docker compose up` and make sure that the db-1 is running (this is the MS Sql database)

<img width="573" alt="image" src="https://user-images.githubusercontent.com/2326083/202495101-63d56397-2bba-49ac-8e8e-3a49ec6c2f19.png">

In order to run the project make sure that the web project is selected as the start project.

It should run under this url:
`https://localhost:7298/swagger/index.html`

It should look like this

<img width="1920" alt="image" src="https://user-images.githubusercontent.com/2326083/202498350-34868827-0dd4-4db1-a762-34d539236813.png">

# Challenge

## Background
The flights API endpoint is used all across LimeFlight and consumed by our single page application, MVC application and our mobile app and also used by internal Azure functions and external systems from our customers.
It is central to the LimeFlight application to display flights to our users. 

# Part one
As you can see based on the code it was created by a standard scaffolding template from Microsoft. This is not suitable for an enterprise application in terms of future extensability and maintainability.
Your job is to refactor the code to make sure it is more future proven and maintainable and suitable for enterprise application with uptime SLA's of 99.9%. 
Feel free to introduce any new pattern, ideas, concepts that you think might fit.

# Part two
Flights are updated on a real time basis with new information like gate changes, aircraft changes, departure times changes etc which are normal on the day of operation in the airline industry. Our users want to see the full history on how a flight has been updated over time. 
So we need to adapt the current flight resource endpoint in a way, so that we can store the full history of flights and the users have full traceability. Keep in mind this is a breaking change for our current api consumers.

Here is the UI prototype

In our flight dashboard the user can click on the flight status of a flight(it shows the latest version of this flight based on the flight departure time:

<img width="1028" alt="image" src="https://user-images.githubusercontent.com/2326083/202512924-0222a788-adbc-4996-9d6f-ed707b84a16b.png">

In the modal all the different versions of a flight are displayed and it's changes are highlighted. 

<img width="1029" alt="image" src="https://user-images.githubusercontent.com/2326083/202513417-8c688f49-244b-4ba4-8177-9ab1b6d54e23.png">













