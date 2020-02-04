# Assignment: Course Sign-up System

Below assignment consists of 3 parts.

The assignment is intentionally made too big, we suggest you spend a maximum of 4 hours on it. Please prepare and send along with the assignment a presentation file explaining what you did and especially how you would take it further to completion.

We want you to tackle all 3 parts. There won't be enough time to code everything. You need to determine which parts of the system you will code and which you will cover in the presentaion. 
In code we will evaluate:

- Domain model design (usage of DDD concepts: aggregates, value objects, domains services, etc)
- Writing and organizing tests
- Asynchrony through messaging (events, commands)
- Namings
- Exception handling and logging
- Code organisation (modularity, dependencies between modules etc)
- Handling concurrency and scaling out your solution

Please ensure that your code has examples of everything mentioned above.

In presentation we want to see:

- Architectural overview
- How you solve each part
- Test strategy for this solution (what to test)
- What tools and technologies you used (libraries, framework, tools etc)
- Knowledge of Azure infrastructure and storage technologies (WebJobs, Azure Functions, SQL, Table Storage, Cosmos DB, ...)
- The problems and challenges that you have faced
- What you think that it can be improved and how


## Case description

You start working at a company that offers online courses.

For each of the courses, there is one teacher/lecturer, and for each of the courses
there is a maximum number of students that can participate. 

To sign up, students need to supply their name and their age.

## Part 1: Prevent from overbooking the course

Create a logic that will sign up students a course. 
If a course is full, it should not be possible to sign up any more.

## Part 2: Scaling out

After few months, the company's courses grow wildly successfull, business is 
booming. There are many courses and millions of sign ups, and your synchronous 
app that uses logic from Part 1 cannot handle the load any more.

Create facility that defers the actual processing to a 
worker process: signing up is processed asynchronously via a message bus.

This works as follows. The API puts a command message on a queue, and the 
message is picked up by the worker process. The worker process tries to sign 
up the student; it then sends an e-mail (implementaion can just log the message) to inform the student whether signing 
up succeeded.

## Part 3: Aggregating & Querying data

For analysis purposes, the company needs to know per course the minimum age, the
maximum age and the average age of students that signed up for the courses.
Consider that this needs to keep working efficiently when there are millions 
of sign-ups per day: calculating this information at every request is unfeasable.

## Wrapping up

Our next interview would start with a 15-20 minutes presentation of your slides, explaining what you did and especially how you would take it further to completion: we want you to not only demonstrate how you code, but also how you transfer knowledge. The rest of the time (40-45 minutes) we will talk about the assignment, how you did it and what are other ways of approaching the problem.

Please attach the presentation file (pdf, ppt, keynote, google slides link) inside your project/repository test.

Please upload the code of the assignment and the presentation at least 24 hours before you present it. You may upload your solution to a github repository, but please don't fork from this assignment repository, as other candidates will then see it. Please do not publish the solution to this assignment in any other way.
