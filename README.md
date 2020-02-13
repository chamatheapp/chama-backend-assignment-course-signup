# Assignment: Course Sign-up System

## Evaluation

The assignment is designed to check your coding and problem-solving skills. It is intentionally made too big. We suggest you spend a maximum of 4 hours on it, therefore you need to decide which components of the system you will code and which you will mock. 
For example, we are more interested in Architecture and Domain model design than in Swagger setup or Mongo repository implementation.

You can use solution skeleton from this repository.

Please send us a link to your git repository. In case you have a private repository, share it with the emails sent to you along with this assignment. The repository must contain code and README.md file in the root directory.

What we evaluate in the code:
- Domain model design (usage of DDD concepts: aggregates, value objects, domain services, etc)
- Messaging (Commands and Events)
- Code organization (modularity, dependencies between modules, etc)
- Exception handling and logging
- Writing and organizing tests
- Task-based asynchronous programming

What we expect to see in the README:
- Architectural overview (knowledge of distributed services, cloud platforms)
- Explanation of solutions for both parts
- Test strategy for this solution (what to test)
- What tools and technologies you used (libraries, framework, tools, storage types, cloud platform features)
- What you think that it can be improved and how
- Anything you will find beneficial to put here

## Case description

You start working at Chama Online University that offers online courses.
For each of the courses, there is one lecturer, and for each of courses there is a maximum number of students that can participate. 
To sign up, students need to supply their email, name and date of birth.

### Part 1: Massive growth

There are many courses and millions of sign-ups.

Create a logic that will sign up students for a course. 
If a course is full, it should not be possible to sign up anymore (even with concurrent requests).

Create a bombastic facility that defers the actual processing to a 
worker process: signing up is processed asynchronously via a message bus. The worker tries to sign up the student then notifies the student whether signing up succeeded or not.

### Part 2: Aggregating & Querying data

For analysis purposes, the company needs to know the minimum, maximum and average age of the students for all courses.
Consider that this needs to keep working efficiently when there are millions
of sign-ups per day. Calculating this statistic at every request is not feasible. 
