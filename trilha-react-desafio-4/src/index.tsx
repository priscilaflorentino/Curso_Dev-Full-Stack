import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import GlobasStyles from './globals';

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
root.render(
  <React.StrictMode>
    <GlobasStyles />
    <App />
  </React.StrictMode>
);

