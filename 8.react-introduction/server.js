// Import the express module
const express = require('express');

// Create an instance of an Express app
const app = express();

// Define the port number. Use the environment variable PORT if available, otherwise use 3000
const port = process.env.PORT || 3000;

// Define a route for the root URL
app.get('/', (req, res) => {
  res.send('Hello World from Docker! Development mode');
});

// Start the server and listen on the specified port
app.listen(port, '0.0.0.0', () => {
  console.log(`Server running in ${process.env.NODE_ENV} mode at http://0.0.0.0:${port}/`);
});