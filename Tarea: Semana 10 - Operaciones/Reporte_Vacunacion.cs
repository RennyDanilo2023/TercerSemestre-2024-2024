#include <iostream>
#include <set>
#include <vector>
#include <algorithm>
#include <iterator>
#include <fstream>

int main() {
    // Crear conjunto ficticio de 500 usuarios (1-500)
    std::set<int> ciudadanos;
    for(int i = 1; i <= 500; ++i) {
        ciudadanos.insert(i);
    }

    // Crear conjunto ficticio de 75 usuarios vacunados con Pfizer (101-175)
    std::set<int> pfizer;
    for(int i = 101; i <= 175; ++i) {
        pfizer.insert(i);
    }

    // Crear conjunto ficticio de 75 usuarios vacunados con AstraZeneca (151-225)
    std::set<int> astrazeneca;
    for(int i = 151; i <= 225; ++i) {
        astrazeneca.insert(i);
    }

    // Listado de ciudadanos no vacunados
    std::set<int> no_vacunados;
    std::set_difference(ciudadanos.begin(), ciudadanos.end(),
                        pfizer.begin(), pfizer.end(),
                        std::inserter(no_vacunados, no_vacunados.begin()));
    std::set_difference(no_vacunados.begin(), no_vacunados.end(),
                        astrazeneca.begin(), astrazeneca.end(),
                        std::inserter(no_vacunados, no_vacunados.begin()));

    // Listado de ciudadanos que han recibido las dos vacunas
    std::set<int> ambas_vacunas;
    std::set_intersection(pfizer.begin(), pfizer.end(),
                          astrazeneca.begin(), astrazeneca.end(),
                          std::inserter(ambas_vacunas, ambas_vacunas.begin()));

    // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
    std::set<int> solo_pfizer;
    std::set_difference(pfizer.begin(), pfizer.end(),
                        astrazeneca.begin(), astrazeneca.end(),
                        std::inserter(solo_pfizer, solo_pfizer.begin()));

    // Listado de ciudadanos que solamente han recibido la vacuna de AstraZeneca
    std::set<int> solo_astrazeneca;
    std::set_difference(astrazeneca.begin(), astrazeneca.end(),
                        pfizer.begin(), pfizer.end(),
                        std::inserter(solo_astrazeneca, solo_astrazeneca.begin()));

    // Guardar resultados en un archivo
    std::ofstream outfile("reporte_vacunacion.txt");
    outfile << "Ciudadanos no vacunados: ";
    for(const auto& ciudadano : no_vacunados) outfile << ciudadano << " ";
    outfile << "\n\nCiudadanos vacunados con ambas vacunas: ";
    for(const auto& ciudadano : ambas_vacunas) outfile << ciudadano << " ";
    outfile << "\n\nCiudadanos vacunados solo con Pfizer: ";
    for(const auto& ciudadano : solo_pfizer) outfile << ciudadano << " ";
    outfile << "\n\nCiudadanos vacunados solo con AstraZeneca: ";
    for(const auto& ciudadano : solo_astrazeneca) outfile << ciudadano << " ";
    outfile.close();

    std::cout << "Reporte generado en 'reporte_vacunacion.txt'" << std::endl;

    return 0;
}
