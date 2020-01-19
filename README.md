# Habit Tracking App

### Tasks
- [ ] Model
- [x] Pick stack
  - Server - ASP.NET Core Web API
  - Client - Sapper

## Model

The whole model for this application is based on this [video](https://www.youtube.com/watch?v=0bxIg3M_MHY) by [Thomas Frank](https://youtube.com/thomasfrank)

## Deployment

### Local Environment

Using the provided Docker Compose configuration which will spin up a (nginx) reverse proxy to handle request for both the client and the server as well as a (PostgreSQL) database instance.

## Stack

### Server

The server is a simple [ASP.NET Core Web API](https://dot.net/) with integration with Google authentication.

### Client

Client uses [Sapper](https://sapper.svelte.dev/). A small client-side framework powered by [Svelte](https://svelte.dev/).
