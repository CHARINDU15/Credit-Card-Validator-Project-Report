import { readFileSync, readFile } from 'fs';
import { createServer } from 'https';
import { join, extname as _extname } from 'path';
import mime from 'mime'; // Use the default export

const options = {
  pfx: readFileSync('C:/Users/USER/Downloads/localhost.pfx'),
  passphrase: '#S20000412c'
};

const server = createServer(options, (req, res) => {
  let filePath = join('C:/Users/USER/Downloads/credit-card-validator/Frontend', req.url === '/' ? 'index.html' : req.url);
  const extname = _extname(filePath);
  const contentType = mime.getType(extname) || 'application/octet-stream';

  readFile(filePath, (error, content) => {
    if (error) {
      if (error.code == 'ENOENT') {
        res.writeHead(404, { 'Content-Type': 'text/html' });
        res.end('<h1>404 Not Found</h1>', 'utf-8');
      } else {
        res.writeHead(500);
        res.end('Sorry, check with the site admin for error: ' + error.code + ' ..\n');
      }
    } else {
      res.writeHead(200, { 'Content-Type': contentType });
      res.end(content, 'utf-8');
    }
  });
});

server.listen(3000, () => {
  console.log('HTTPS Server running at https://localhost:3000');
});