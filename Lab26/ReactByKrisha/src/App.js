import React, { useState } from 'react';
import Navbar from './components/Navbar';
import Footer from './components/Footer';
import Home from './components/Home';
import Calculator from './components/Calculator';

function App() {
  const [page, setPage] = useState('home');

  return (
    <div>
      <Navbar setPage={setPage} />
      {page === 'home' && <Home />}
      {page === 'calculator' && <Calculator />}
      <Footer />
    </div>
  );
}

export default App;
