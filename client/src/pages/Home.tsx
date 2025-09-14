import React from 'react';
import { Link } from 'react-router-dom';
import { Building, Car, Utensils, Users, ArrowRight, Newspaper } from 'lucide-react';

const Home: React.FC = () => {
  const services = [
    {
      title: 'News',
      description: 'Stay updated with the latest news and events',
      icon: Newspaper,
      link: '/news',
      color: 'bg-red-500',
      hoverColor: 'hover:bg-red-600'
    },
    {
      title: 'Apartments',
      description: 'Find and share apartment listings with fellow students',
      icon: Building,
      link: '/apartments',
      color: 'bg-blue-500',
      hoverColor: 'hover:bg-blue-600'
    },
    {
      title: 'Cars',
      description: 'Buy and sell cars within our trusted community',
      icon: Car,
      link: '/cars',
      color: 'bg-green-500',
      hoverColor: 'hover:bg-green-600'
    },
    {
      title: 'Foods & Groceries',
      description: 'Discover international food options and restaurants',
      icon: Utensils,
      link: '/foodsandgroceries',
      color: 'bg-yellow-500',
      hoverColor: 'hover:bg-yellow-600'
    },
    {
      title: 'P2P Marketplace',
      description: 'Buy and sell items directly with other students',
      icon: Users,
      link: '/p2p',
      color: 'bg-purple-500',
      hoverColor: 'hover:bg-purple-600'
    }
  ];

  return (
    <div>
      <section className="text-center mb-16">
        <h1 className="text-4xl md:text-5xl font-bold text-gray-900 mb-6">
          Welcome International Students in Latvia! 🌍🇱🇻
        </h1>
        <p className="text-xl text-gray-600 max-w-3xl mx-auto mb-8">
          Your trusted community platform for finding news, apartments, cars, foods & groceries,
          and connecting with fellow international students across Latvia.
        </p>
        <div className="flex flex-col sm:flex-row gap-4 justify-center">
          <Link
            to="/contact"
            className="bg-blue-600 text-white px-8 py-3 rounded-lg font-semibold hover:bg-blue-700 transition-colors"
          >
            Join Our Community
          </Link>
          <Link
            to="/p2p"
            className="border border-gray-300 text-gray-700 px-8 py-3 rounded-lg font-semibold hover:bg-gray-50 transition-colors"
          >
            Browse Marketplace
          </Link>
        </div>
      </section>

      <section className="mb-16">
        <h2 className="text-3xl font-bold text-center text-gray-900 mb-12">
          What Can You Find Here?
        </h2>
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
          {services.map((service) => {
            const Icon = service.icon;
            return (
              <Link
                key={service.title}
                to={service.link}
                className="bg-white rounded-xl shadow-md p-6 hover:shadow-xl transition-all duration-300 transform hover:-translate-y-1"
              >
                <div className={`w-14 h-14 ${service.color} rounded-xl flex items-center justify-center mb-4 ${service.hoverColor} transition-colors`}>
                  <Icon className="text-white" size={28} />
                </div>
                <h3 className="text-xl font-semibold mb-3 text-gray-900">{service.title}</h3>
                <p className="text-gray-600 mb-4">{service.description}</p>
                <div className="flex items-center text-blue-600 font-medium">
                  <span>Explore</span>
                  <ArrowRight size={16} className="ml-1" />
                </div>
              </Link>
            );
          })}
        </div>
      </section>

      <section className="bg-white rounded-xl shadow-lg p-8 mb-16">
        <div className="grid grid-cols-1 md:grid-cols-3 gap-8 text-center">
          <div>
            <h3 className="text-3xl font-bold text-blue-600 mb-2">500+</h3>
            <p className="text-gray-600">Active Students</p>
          </div>
          <div>
            <h3 className="text-3xl font-bold text-green-600 mb-2">200+</h3>
            <p className="text-gray-600">Listings Posted</p>
          </div>
          <div>
            <h3 className="text-3xl font-bold text-purple-600 mb-2">10</h3>
            <p className="text-gray-600">Cities Covered</p>
          </div>
        </div>
      </section>

      <section className="text-center bg-gradient-to-r from-blue-600 to-purple-600 text-blue-2  b00 rounded-xl p-8">
        <h2 className="text-2xl md:text-3xl font-bold mb-4">
          Ready to Connect with Your Community?
        </h2>
        <p className="text-lg mb-6 opacity-90">
          Join hundreds of international students making the most of their time in Latvia
        </p>
        <Link
          to="/contact"
          className="bg-white text-blue-600 px-8 py-3 rounded-lg font-semibold hover:bg-gray-100 transition-colors inline-flex items-center"
        >
          Get Started Today
          <ArrowRight size={20} className="ml-2" />
        </Link>
      </section>
    </div>
  );
};

export default Home;