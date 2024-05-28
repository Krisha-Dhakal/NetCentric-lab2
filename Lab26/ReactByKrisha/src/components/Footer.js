import React from 'react';
import './css/Footer.css'; // Import Footer CSS

const Footer = () => {
  return (
    <footer className="footer">
      
      <p>&copy; ReactJS, {new Date().getFullYear()}</p>
    </footer>
  );
}

export default Footer;
