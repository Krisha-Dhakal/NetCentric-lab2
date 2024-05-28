import React from 'react';
import './css/Home.css'; // Import Home CSS
import reactImage from './image.png';

const Home = () => {
  return (
    <div className="home-container">
      <img src={reactImage} alt="Sample" className="home-image" />
    </div>
  );
}

export default Home;
