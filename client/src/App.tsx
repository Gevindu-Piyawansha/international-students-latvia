import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Layout from './components/layout/Layout';
import Home from './pages/Home';

// Placeholder components - we'll create these next
const Apartments: React.FC = () => (
  <div className="text-center py-16">
    <h1 className="text-3xl font-bold">Apartments - Coming Soon!</h1>
    <p className="text-gray-600 mt-4">Find and share apartment listings with fellow students.</p>
  </div>
);

const Cars: React.FC = () => (
  <div className="text-center py-16">
    <h1 className="text-3xl font-bold">Cars - Coming Soon!</h1>
    <p className="text-gray-600 mt-4">Buy and sell cars within our community.</p>
  </div>
);

const Foods: React.FC = () => (
  <div className="text-center py-16">
    <h1 className="text-3xl font-bold">Foods - Coming Soon!</h1>
    <p className="text-gray-600 mt-4">Discover international food options.</p>
  </div>
);

const P2P: React.FC = () => (
  <div className="text-center py-16">
    <h1 className="text-3xl font-bold">P2P Marketplace - Coming Soon!</h1>
    <p className="text-gray-600 mt-4">Buy and sell items with fellow students.</p>
  </div>
);

const Contact: React.FC = () => (
  <div className="text-center py-16">
    <h1 className="text-3xl font-bold">Contact - Coming Soon!</h1>
    <p className="text-gray-600 mt-4">Get in touch with our community.</p>
  </div>
);

function App() {
  return (
    <Router>
      <Layout>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/apartments" element={<Apartments />} />
          <Route path="/cars" element={<Cars />} />
          <Route path="/foods" element={<Foods />} />
          <Route path="/p2p" element={<P2P />} />
          <Route path="/contact" element={<Contact />} />
        </Routes>
      </Layout>
    </Router>
  );
}

export default App;
