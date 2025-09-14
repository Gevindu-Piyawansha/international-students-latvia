import React from 'react';
import { Header } from './Header';

interface LayoutProps {
  children: React.ReactNode;
}

const Layout: React.FC<LayoutProps> = ({ children }) => {
  return (
    <div className="min-h-screen bg-gray-50">
      <Header />
      <main className="container mx-auto px-4 py-8">
        {children}
      </main>
      <footer className="bg-gray-800 text-white py-8 mt-16">
        <div className="container mx-auto px-4">
          <div className="grid grid-cols-1 md:grid-cols-3 gap-8">
            <div>
              <h3 className="text-lg font-semibold mb-4">International Students Latvia</h3>
              <p className="text-gray-300">
                Connecting international students in Latvia through shared resources and community.
              </p>
            </div>
            <div>
              <h4 className="text-md font-semibold mb-4">Quick Links</h4>
              <ul className="space-y-2 text-gray-300">
                <li><a href="/news" className="hover:text-white">News</a></li>
                <li><a href="/apartments" className="hover:text-white">Apartments</a></li>
                <li><a href="/cars" className="hover:text-white">Cars</a></li>
                <li><a href="/foodsandgroceries" className="hover:text-white">Foods & Groceries</a></li>
                <li><a href="/p2p" className="hover:text-white">P2P Marketplace</a></li>
              </ul>
            </div>
            <div>
              <h4 className="text-md font-semibold mb-4">Contact</h4>
              <p className="text-gray-300">
                Have questions? <a href="/contact" className="text-blue-400 hover:text-blue-300">Contact us</a>
              </p>
            </div>
          </div>
          <div className="border-t border-gray-700 mt-8 pt-8 text-center text-gray-300">
            <p>&copy; 2024 International Students Latvia. All rights reserved.</p>
          </div>
        </div>
      </footer>
    </div>
  );
};

export default Layout;