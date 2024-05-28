import React from 'react';
import './css/Navbar.css'; // Import Navbar CSS

const Navbar = ({ setPage }) => {
  return (
    <nav className="navbar">
      <ul className="navbar-list">
        <li className="navbar-item" onClick={() => setPage('home')}>
          <a className="navbar-link" href="#/">Home</a>
        </li>
        <li className="navbar-item" onClick={() => setPage('calculator')}>
          <a className="navbar-link" href="#/">Calculator</a>
        </li>
      </ul>
    </nav>
  );
}

export default Navbar;
