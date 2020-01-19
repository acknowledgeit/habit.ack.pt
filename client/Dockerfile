FROM mhart/alpine-node:12

WORKDIR /app

# install dependencies
COPY package.json package-lock.json ./
RUN npm install

# build app
COPY . .
RUN npm run build

# Set environment variables and port
ENV NODE_ENV production
ENV PORT 3000
EXPOSE 3000

ENTRYPOINT ["node", "__sapper__/build"]
