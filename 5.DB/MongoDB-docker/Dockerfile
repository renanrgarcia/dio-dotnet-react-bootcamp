# Use the official MongoDB image as the base
FROM mongo:latest

# Install MongoDB client tools
RUN apt-get update && apt-get install -y mongodb-org

# Expose the MongoDB default port
EXPOSE 27017

# Command to run the MongoDB server
CMD ["mongod"]
