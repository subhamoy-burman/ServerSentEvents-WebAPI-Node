const express = require('express');
const app = express();

app.use(express.static('./'));  // Serve your HTML/JS files from the 'public' directory

app.listen(3000, () => console.log('Server listening on port 3000'));
